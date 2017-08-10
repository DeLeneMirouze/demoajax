namespace DemoAjax.Model
{
    public class FormViewModelBuilder
    {
        #region Build
        public FormViewModel Build()
        {
            FormViewModel vm = new FormViewModel();
            vm.EtatCivil = new EtatCivil();

            LoadReferences(vm);

            return vm;
        }
        #endregion

        #region LoadReferences
        public void LoadReferences(FormViewModel vm)
        {
            Civilite cv = new Civilite() { Id = 1, Label = "Monsieur" };
            vm.Civilites.Add(cv);

            cv = new Civilite() { Id = 2, Label = "Madame" };
            vm.Civilites.Add(cv);

            cv = new Civilite() { Id = 3, Label = "Mademoiselle" };
            vm.Civilites.Add(cv);
        } 
        #endregion
    }
}