namespace Functionality
{
    public class History
    {
        private decimal nr1 { get; set; }
        private string operation { get; set; }
        private decimal nr2 { get; set; }
        private decimal answer { get; set; }

        public History(decimal nr1, string operation, decimal nr2, decimal answer)
        {
            this.nr1 = nr1;
            this.operation = operation;
            this.nr2 = nr2;
            this.answer = answer;
        }
    }
    public class SavedHistory
    {
        private List<SavedHistory> calcHistory { get; set; }

        public SavedHistory(List<SavedHistory> calcHistory)
        {
            this.calcHistory = calcHistory;
        }
    }
}