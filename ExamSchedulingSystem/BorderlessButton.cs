namespace ExamSchedulingSystem
{
    internal class BorderlessButton : Button
    {
        public override void NotifyDefault(bool value) => base.NotifyDefault(false);
    }
}
