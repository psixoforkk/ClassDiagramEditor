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
        private bool associationConnectorCheck;
        private bool inheritanceConnectorCheck;
        private bool implementationConnectorCheck;
        private bool dependencyConnectorCheck;
        private bool aggregationConnectorCheck;
        private bool compositionConnectorCheck;
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
            Diagrams.Add(new MyTypeInterface
            {
                Height = 100,
                Width = 100,
                Name = "Name2",
                StartPoint = new Avalonia.Point(100, 200)
            });
        }
        public bool ClassDiagramCheck
        {
            get => classDiagramCheck;
            set => this.RaiseAndSetIfChanged(ref classDiagramCheck, value);
        }
        public bool InterfaceDiagramCheck
        {
            get => interfaceDiagramCheck;
            set => this.RaiseAndSetIfChanged(ref interfaceDiagramCheck, value);
        }
        public bool AssociationConnectorCheck
        {
            get => associationConnectorCheck;
            set => this.RaiseAndSetIfChanged(ref associationConnectorCheck, value);
        }
        public bool InheritanceConnectorCheck
        {
            get => inheritanceConnectorCheck;
            set => this.RaiseAndSetIfChanged(ref inheritanceConnectorCheck, value);
        }
        public bool ImplementationConnectorCheck
        {
            get => implementationConnectorCheck;
            set => this.RaiseAndSetIfChanged(ref implementationConnectorCheck, value);
        }
        public bool DependencyConnectorCheck
        {
            get => dependencyConnectorCheck;
            set => this.RaiseAndSetIfChanged(ref dependencyConnectorCheck, value);
        }
        public bool AggregationConnectorCheck
        {
            get => aggregationConnectorCheck;
            set => this.RaiseAndSetIfChanged(ref aggregationConnectorCheck, value);
        }
        public bool CompositionConnectorCheck
        {
            get => compositionConnectorCheck;
            set => this.RaiseAndSetIfChanged(ref compositionConnectorCheck, value);
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
        public ObservableCollection<IType> Diagrams
        {
            get => diagrams;
            set => this.RaiseAndSetIfChanged(ref diagrams, value);
        }
    }
}
