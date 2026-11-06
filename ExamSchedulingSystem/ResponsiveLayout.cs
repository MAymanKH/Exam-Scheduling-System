namespace ExamSchedulingSystem
{
    internal static class ResponsiveLayout
    {
        internal static int Pixels(Control control, int value) => (int)Math.Round(value * control.DeviceDpi / 96d);

        internal static void Fields(Form form, params Control[] controls)
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
                foreach (var label in controls.OfType<Label>()) label.MaximumSize = new Size(fields.Width, 0);
                fields.Location = new Point(Math.Max(gap, (viewport.ClientSize.Width - fields.Width) / 2),
                    Math.Max(0, (viewport.ClientSize.Height - fields.Height) / 2) + viewport.AutoScrollPosition.Y);
            }
            viewport.Resize += (_, _) => Arrange();
            fields.SizeChanged += (_, _) => Arrange();
            Arrange();
        }

        internal static void Import(Form form, Label source, TextBox input, Button action, Panel card)
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
            form.Controls.Add(layout);
            void Arrange()
            {
                bool narrow = form.ClientSize.Width < Pixels(form, 620);
                layout.SuspendLayout();
                layout.SetColumnSpan(input, narrow ? 2 : 1);
                layout.SetCellPosition(action, new TableLayoutPanelCellPosition(narrow ? 0 : 1, narrow ? 2 : 1));
                layout.SetColumnSpan(action, narrow ? 2 : 1);
                layout.RowCount = narrow ? 4 : 3;
                layout.SetCellPosition(card, new TableLayoutPanelCellPosition(0, narrow ? 3 : 2));
                layout.RowStyles.Clear();
                for (int i = 0; i < layout.RowCount - 1; i++) layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
                layout.ResumeLayout(true);
            }
            form.Resize += (_, _) => Arrange();
            Arrange();
        }

        internal static void Dashboard(Form form, Panel content, Label title, Button generate, Panel[] cards,
            Panel preview, Button view, DataGridView grid)
        {
            form.MinimumSize = new Size(720, 500);
            var dashboard = new Panel { Dock = DockStyle.Fill };
            foreach (var control in content.Controls.Cast<Control>().ToArray()) { control.Anchor = AnchorStyles.Top | AnchorStyles.Left; dashboard.Controls.Add(control); }
            content.Controls.Add(dashboard);
            void Arrange()
            {
                dashboard.AutoScroll = false;
                dashboard.AutoScrollMinSize = Size.Empty;
                int gap = Pixels(form, 16), width = Math.Max(Pixels(form, 400), dashboard.ClientSize.Width - gap * 2);
                int columns = width >= Pixels(form, 880) ? 4 : 2;
                int cardWidth = (width - gap * (columns - 1)) / columns;
                int cardHeight = Pixels(form, 115);
                int top = gap + Math.Max(title.Height, generate.Height) + gap;
                var offset = dashboard.AutoScrollPosition;
                title.Location = new Point(gap + offset.X, gap + offset.Y);
                generate.Location = new Point(gap + width - generate.Width + offset.X, gap + offset.Y);
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i].SetBounds(gap + i % columns * (cardWidth + gap) + offset.X,
                        top + i / columns * (cardHeight + gap) + offset.Y, cardWidth, cardHeight);
                    foreach (var label in cards[i].Controls.OfType<Label>())
                        if (label.Font == AppStyle.Metric) label.Left = (cardWidth - label.Width) / 2;
                }
                int previewTop = top + (cards.Length / columns) * (cardHeight + gap);
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

        internal static void Timetable(Form form, Panel editor, Label status, Button apply,
            params (Label Label, Control Input)[] fields)
        {
            form.MinimumSize = new Size(400, 500);
            var flow = new FlowLayoutPanel { Dock = DockStyle.Top, AutoSize = true, WrapContents = true, Padding = new Padding(8) };
            foreach (var field in fields)
            {
                var group = new Panel { Size = new Size(field.Input.Width + 8, Pixels(form, 64)), Margin = new Padding(0, 0, 8, 0) };
                group.Controls.Add(field.Label);
                group.Controls.Add(field.Input);
                field.Label.Location = Point.Empty;
                field.Input.Location = new Point(0, Pixels(form, 24));
                flow.Controls.Add(group);
            }
            apply.Margin = new Padding(0, Pixels(form, 20), 0, 0);
            flow.Controls.Add(apply);
            status.Dock = DockStyle.None;
            status.Height = Pixels(form, 44);
            editor.Controls.Add(flow);
            editor.SizeChanged += (_, _) => status.SetBounds(Pixels(form, 8), editor.Height - status.Height, editor.Width - Pixels(form, 16), status.Height);
            void Arrange() => editor.Height = flow.GetPreferredSize(new Size(editor.ClientSize.Width, 0)).Height + status.Height;
            flow.SizeChanged += (_, _) => Arrange();
            form.Resize += (_, _) => Arrange();
            Arrange();
        }
    }
}
