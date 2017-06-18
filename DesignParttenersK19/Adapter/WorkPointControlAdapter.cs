namespace DesignParttenersK19.Adapter
{
    public class WorkPointControlAdapter:WorkPointControl
    {
        private NewWorkPointControl _newWorkPointControl;
        public WorkPointControlAdapter()
        {
            _newWorkPointControl = new NewWorkPointControl();
        }

        public new void RegistreEntry(Employee employee)
        {
            _newWorkPointControl.Registre(employee,true);
        }

        public new void RegistreOut(Employee employee)
        {
            _newWorkPointControl.Registre(employee,false);
        }
    }
}