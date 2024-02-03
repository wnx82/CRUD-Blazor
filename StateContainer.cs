using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//coucou
using CRUD.Entities;

namespace CRUD
{
    public class StateContainer
    {

        #region Employe
        private List<Employe> employes= new();
        private Employe? selectedEmploye = null;

        public List<Employe> Employes
        {
            get => employes;
            set
            {
                employes = value;
                NotifyEmployesUpdated();
            }
        }

        public Employe? SelectedEmploye
        {
            get => selectedEmploye;
            set
            {
                selectedEmploye = value;
                OnEmployeSelected?.Invoke();
            }
        }

        public event Action? OnEmployeUpdated;
        public event Action? OnEmployeSelected;

        public void NotifyEmployesUpdated() => OnEmployeUpdated?.Invoke();
        #endregion
    }
}