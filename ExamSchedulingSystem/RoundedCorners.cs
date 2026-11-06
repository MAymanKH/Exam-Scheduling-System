using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace ExamSchedulingSystem
{
    internal static class RoundedCorners
    {
        private static readonly ConditionalWeakTable<Control, object> Styled = new();

        internal static void Apply(Control control)
        {
            if (Styled.TryGetValue(control, out _)) return;
            Styled.Add(control, new object());

            int radius = control switch
            {
                Button => 10,
                TextBoxBase or ComboBox or DateTimePicker or UpDownBase => 6,
                DataGridView => 8,
                SummaryChart => 12,
                Panel when control is not TableLayoutPanel && control is not FlowLayoutPanel
                    && control.Parent != null && control.BackColor != control.Parent.BackColor => 12,
                _ => 0
            };

            if (radius > 0)
            {
                void UpdateRegion(object? sender, EventArgs args)
                {
                    var previous = control.Region;
                    if (control.Width > 0 && control.Height > 0)
                    {
                        float diameter = Math.Min(radius * 2f * control.DeviceDpi / 96f,
                            Math.Min(control.Width, control.Height));
                        using var path = new GraphicsPath();
                        path.AddArc(0, 0, diameter, diameter, 180, 90);
                        path.AddArc(control.Width - diameter, 0, diameter, diameter, 270, 90);
                        path.AddArc(control.Width - diameter, control.Height - diameter, diameter, diameter, 0, 90);
                        path.AddArc(0, control.Height - diameter, diameter, diameter, 90, 90);
                        path.CloseFigure();
                        control.Region = new Region(path);
                    }
                    else control.Region = null;
                    previous?.Dispose();
                }

                control.SizeChanged += UpdateRegion;
                control.DpiChangedAfterParent += UpdateRegion;
                control.Disposed += (_, _) => control.Region?.Dispose();
                UpdateRegion(control, EventArgs.Empty);
            }

            control.ControlAdded += (_, args) =>
            {
                if (args.Control != null) Apply(args.Control);
            };
            foreach (Control child in control.Controls) Apply(child);
        }
    }
}