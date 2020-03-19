using SortingVisualizer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace SortingVisualizer.Commands
{
    class SortCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        ArrayVisualizerViewModel view;

        public SortCommand(ArrayVisualizerViewModel view)
        {
            this.view = view;
        }

        public bool CanExecute(object parameter)
        {
            if (parameter.ToString() == "Reset")
                return true;
            return !view.Sorting;
        }

        public void Execute(object parameter)
        {
            view.Stop = false;
            switch (parameter.ToString())
            {
                case "Bubble":
                    view.BubbleSort();
                    break;
                case "Selection":
                    view.SelectionSort();
                    break;
                case "Reset":
                    view.Reset();
                    break;
            }
        }
    }
}
