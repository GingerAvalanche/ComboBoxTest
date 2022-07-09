using ReactiveUI;

namespace ComboBoxTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string[] fl1 = new[] { "0", "1", "2", "3" };
        public string f1 = "";
        public string[] fl2 = new string[4];
        public string f2 = "";
        public string[] fl3 = new string[4];
        public string f3 = "";
        public string[] fl4 = new string[4];
        public string f4 = "";
        public string[] PL1
        {
            get => fl1;
            set
            {
                this.RaiseAndSetIfChanged(ref fl1, value);
                P1 = fl1[0];
            }
        }
        public string[] PL2
        {
            get => fl2;
            set
            {
                this.RaiseAndSetIfChanged(ref fl2, value);
                P2 = fl2[0];
            }
        }
        public string[] PL3
        {
            get => fl3;
            set
            {
                this.RaiseAndSetIfChanged(ref fl3, value);
                P3 = fl3[0];
            }
        }
        public string[] PL4
        {
            get => fl4;
            set
            {
                this.RaiseAndSetIfChanged(ref fl4, value);
                P4 = fl4[0];
            }
        }
        public string P1
        {
            get => f1;
            set
            {
                this.RaiseAndSetIfChanged(ref f1, value);
                if (value is not null)
                    PL2 = new[] { $"{fl1[int.Parse(f1[^1..])]}0", $"{fl1[int.Parse(f1[^1..])]}1", $"{fl1[int.Parse(f1[^1..])]}2", $"{fl1[int.Parse(f1[^1..])]}3",};
            }
        }
        public string P2
        {
            get => f2;
            set
            {
                this.RaiseAndSetIfChanged(ref f2, value);
                if (value is not null)
                    PL3 = new[] { $"{fl2[int.Parse(f2[^1..])]}0", $"{fl2[int.Parse(f2[^1..])]}1", $"{fl2[int.Parse(f2[^1..])]}2", $"{fl2[int.Parse(f2[^1..])]}3", };
            }
        }
        public string P3
        {
            get => f3;
            set
            {
                this.RaiseAndSetIfChanged(ref f3, value);
                if (value is not null)
                    PL4 = new[] { $"{fl3[int.Parse(f3[^1..])]}0", $"{fl3[int.Parse(f3[^1..])]}1", $"{fl3[int.Parse(f3[^1..])]}2", $"{fl3[int.Parse(f3[^1..])]}3", };
            }
        }
        public string P4
        {
            get => f4;
            set
            {
                this.RaiseAndSetIfChanged(ref f4, value);
            }
        }

        public MainWindowViewModel()
        {
            for (int i = 0; i < fl2.Length; i++)
            {
                fl2[i] = $"{fl1[i]}{i}";
            }
            for (int i = 0; i < fl3.Length; i++)
            {
                fl3[i] = $"{fl2[i]}{i}";
            }
            for (int i = 0; i < fl4.Length; i++)
            {
                fl4[i] = $"{fl3[i]}{i}";
            }
        }
    }
}
