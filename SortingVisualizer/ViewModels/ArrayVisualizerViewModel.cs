using SortingVisualizer.Commands;
using SortingVisualizer.Models;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace SortingVisualizer.ViewModels
{
    internal class ArrayVisualizerViewModel
    {
        public const int delay = 10;

        public SortCommand Sort { get; }
        public bool Stop { get; internal set; }
        public bool Sorting { get; private set; }

        private ValueModel[] ValueModels;
        private int amount = 100;

        public ArrayVisualizerViewModel(Canvas canvas)
        {
            Sort = new SortCommand(this);

            ValueModels = new ValueModel[amount];
            for (int i = 0; i < amount; i++)
            {
                ValueModels[i] = new ValueModel(canvas, i);
            }
        }

        private void Swap(int a, int b)
        {
            var temp = ValueModels[a];
            ValueModels[a] = ValueModels[b];
            ValueModels[b] = temp;
            ValueModels[a].Id = a;
            ValueModels[b].Id = b;
        }

        public void Reset()
        {
            Stop = true;
            Sorting = false;
            for (int i = 0; i < ValueModels.Length; i++)
            {
                ValueModels[i].Line.Stroke = Brushes.White;
                ValueModels[i].RandomizeValue();
            }
        }

        //Bubble sort
        public async void BubbleSort()
        {
            Sorting = true;
            for (int i = 0; i < ValueModels.Length; i++)
            {
                for (int j = 0; j < ValueModels.Length - 1; j++)
                {
                    if (Stop)
                        return;
                    if (ValueModels[j].Value > ValueModels[j + 1].Value)
                    {
                        Swap(j, j + 1);
                        await Task.Delay(delay);
                    }
                }
            }
        }

        //Selection sort
        public async void SelectionSort()
        {
            Sorting = true;
            for (int i = 0; i < ValueModels.Length - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < ValueModels.Length; j++)
                {
                    if (Stop)
                        return;
                    if (ValueModels[index].Value > ValueModels[j].Value)
                    {
                        index = j;
                    }
                }
                Swap(index, i);
                await Task.Delay(delay);
            }
        }
    }
}
