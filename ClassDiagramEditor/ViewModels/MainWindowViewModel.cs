using ClassDiagramEditor.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ClassDiagramEditor.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<IType> diagrams;
        private bool classDiagramCheck;
        private bool interfaceDiagramCheck;
        private bool addDiagramCheck;
        private bool scaleDiagramCheck;
        private bool deleteDiagramCheck;

        public MainWindowViewModel()
        {
            Diagrams = new ObservableCollection<IType>();
            AddDiagramCheck = true;
            Diagrams.Add(new MyTypeClass
            {
                Height = 100,
                Width = 100,
                Name = "Name",
                StartPoint = new Avalonia.Point(100, 100)
            });
            Diagrams.Add(new MyTypeClass
            {
                Height = 100,
                Width = 100,
                Name = "Name1",
                StartPoint = new Avalonia.Point(500, 100)
            });
        }
        public bool ClassDiagramCheck
        {
            get => classDiagramCheck;
            set => this.RaiseAndSetIfChanged(ref classDiagramCheck, value);
        }
        public bool AddDiagramCheck
        {
            get => addDiagramCheck;
            set => this.RaiseAndSetIfChanged(ref addDiagramCheck, value);
        }
        public bool ScaleDiagramCheck
        {
            get => scaleDiagramCheck;
            set => this.RaiseAndSetIfChanged(ref scaleDiagramCheck, value);
        }
        public bool DeleteDiagramCheck
        {
            get => deleteDiagramCheck;
            set => this.RaiseAndSetIfChanged(ref deleteDiagramCheck, value);
        }
        public bool InterfaceDiagramCheck
        {
            get => interfaceDiagramCheck;
            set => this.RaiseAndSetIfChanged(ref interfaceDiagramCheck, value);
        }
        public ObservableCollection<IType> Diagrams
        {
            get => diagrams;
            set => this.RaiseAndSetIfChanged(ref diagrams, value);
        }
    }
}
