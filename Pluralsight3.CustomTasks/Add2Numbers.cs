using Microsoft.Build.Framework;

namespace Pluralsight3.CustomTasks
{
    public class Add2Numbers : Microsoft.Build.Utilities.Task
    {
        [Required]
        public int Number1 { get; set; }

        [Required]
        public int Number2 { get; set; }

        [Output]
        public int Result { get; set; }

        public override bool Execute()
        {
            Result = Number1 + Number2;
            BuildEngine.LogMessageEvent(new BuildMessageEventArgs("Add 2 numbers", "Add", "Add2Numbers", MessageImportance.High));

            return true;
        }
    }
}
