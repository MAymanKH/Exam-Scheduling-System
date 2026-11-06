namespace ExamSchedulingSystem
{
    internal static class ResponsiveLayout
    {
        internal static int Pixels(Control control, int value) => (int)Math.Round(value * control.DeviceDpi / 96d);

        internal static TableLayoutPanel Fields(Form form, params Control[] controls)
        {
            form.MinimumSize = new Size(360, 360);
            var viewport = new Panel { Dock = DockStyle.Fill, AutoScroll = true };
            var fields = new TableLayoutPanel
            {
                AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink,
                ColumnCount = 1, Padding = new Padding(0, 16, 0, 16),
                BackColor = form.BackColor
            };
            fields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            foreach (var control in controls)
            {
                control.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                control.Margin = new Padding(0, 0, 0, control is Label ? 8 : 20);
                if (control is Label label) label.AutoSize = true;
                fields.Controls.Add(control);
            }
            viewport.Controls.Add(fields);
            form.Controls.Add(viewport);
            viewport.BringToFront();
            void Arrange()
            {
                int gap = Pixels(form, 24);
                fields.Width = Math.Max(1, Math.Min(Pixels(form, 520), viewport.ClientSize.Width - gap * 2));
                foreach (var label in controls.OfType<Label>()) label.MaximumSize = new Size(Math.Max(1, fields.Width - fields.Padding.Horizontal), 0);
                fields.Location = new Point(Math.Max(gap, (viewport.ClientSize.Width - fields.Width) / 2),
                    Math.Max(0, (viewport.ClientSize.Height - fields.Height) / 2) + viewport.AutoScrollPosition.Y);
            }
            viewport.Resize += (_, _) => Arrange();
            fields.SizeChanged += (_, _) => Arrange();
            Arrange();
            return fields;
        }

        internal static void Import(Form form, Label source, TextBox input, Button action, Panel card, SummaryChart chart)
        {
            form.MinimumSize = new Size(400, 400);
            form.AutoScroll = false;
            var layout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 3, Padding = new Padding(24) };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            layout.Controls.Add(source, 0, 0);
            layout.SetColumnSpan(source, 2);
            source.Margin = new Padding(0, 0, 0, 8);
            layout.Controls.Add(input, 0, 1);
            input.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            input.Margin = new Padding(0, 0, 16, 16);
            layout.Controls.Add(action, 1, 1);
            action.Margin = new Padding(0, 0, 0, 16);
            layout.Controls.Add(card, 0, 2);
            layout.SetColumnSpan(card, 2);
            card.Dock = DockStyle.Fill;
            card.Margin = Padding.Empty;
            var body = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 2, Margin = Padding.Empty };
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            body.RowStyles.Add(new RowStyle(SizeType.Absolute, chart.Height + 12));
            body.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            chart.Dock = DockStyle.Fill;
            chart.Margin = new Padding(0, 0, 0, 12);
            body.Controls.Add(chart, 0, 0);
            body.Controls.Add(card, 0, 1);
            var grid = card.Controls.OfType<DataGridView>().Single();
            void SizeGrid() => grid.SetBounds(16, 68, Math.Max(1, card.ClientSize.Width - 32), Math.Max(1, card.ClientSize.Height - 84));
            card.SizeChanged += (_, _) => SizeGrid();
            SizeGrid();
            layout.Controls.Add(body, 0, 2);
            layout.SetColumnSpan(body, 2);
            form.Controls.Add(layout);
            void Arrange()
            {
                body.RowStyles[0].Height = Pixels(form, Math.Clamp(form.ClientSize.Height / 4, 116, 186)) + Pixels(form, 12);
                bool narrow = form.ClientSize.Width < Pixels(form, 620);
                layout.SuspendLayout();
                layout.SetColumnSpan(input, narrow ? 2 : 1);
                layout.SetCellPosition(action, new TableLayoutPanelCellPosition(narrow ? 0 : 1, narrow ? 2 : 1));
                layout.SetColumnSpan(action, narrow ? 2 : 1);
                layout.RowCount = narrow ? 4 : 3;
                layout.SetCellPosition(body, new TableLayoutPanelCellPosition(0, narrow ? 3 : 2));
                layout.RowStyles.Clear();
                for (int i = 0; i < layout.RowCount - 1; i++) layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
                layout.ResumeLayout(true);
            }
            form.Resize += (_, _) => Arrange();
            Arrange();
        }

        internal static void Dashboard(Form form, Panel content, Label title, SummaryChart chart, Panel[] cards,
            Panel preview, Button view, DataGridView grid)
        {
            form.MinimumSize = new Size(720, 500);
            var dashboard = new Panel { Dock = DockStyle.Fill };
            foreach (var control in content.Controls.Cast<Control>().ToArray()) { control.Anchor = AnchorStyles.Top | AnchorStyles.Left; dashboard.Controls.Add(control); }
            content.Controls.Add(dashboard);
            dashboard.Controls.Add(chart);
            void Arrange()
            {
                dashboard.AutoScroll = false;
                dashboard.AutoScrollMinSize = Size.Empty;
                int gap = Pixels(form, 16), width = Math.Max(Pixels(form, 400), dashboard.ClientSize.Width - gap * 2);
                int columns = width >= Pixels(form, 880) ? 4 : 2;
                int cardWidth = (width - gap * (columns - 1)) / columns;
                int cardHeight = Pixels(form, 115);
                int top = gap + title.Height + gap;
                var offset = dashboard.AutoScrollPosition;
                title.Location = new Point(gap + offset.X, gap + offset.Y);

                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i].SetBounds(gap + i % columns * (cardWidth + gap) + offset.X,
                        top + i / columns * (cardHeight + gap) + offset.Y, cardWidth, cardHeight);
                    foreach (var label in cards[i].Controls.OfType<Label>())
                        if (label.Font == AppStyle.Metric) label.Left = (cardWidth - label.Width) / 2;
                }
                int previewTop = top + (cards.Length / columns) * (cardHeight + gap);
                chart.SetBounds(gap + offset.X, previewTop + offset.Y, width, Pixels(form, 164));
                previewTop += chart.Height + gap;
                preview.SetBounds(gap + offset.X, previewTop + offset.Y, width,
                    Math.Max(Pixels(form, 240), dashboard.ClientSize.Height - previewTop - gap));
                view.Location = new Point(preview.Width - view.Width - gap, gap);
                grid.SetBounds(gap, Pixels(form, 80), preview.Width - gap * 2, preview.Height - Pixels(form, 80) - gap);
                dashboard.AutoScrollMinSize = new Size(0, previewTop + preview.Height + gap);
                dashboard.AutoScroll = true;
            }
            dashboard.Resize += (_, _) => Arrange();
            Arrange();
        }

    }
}
