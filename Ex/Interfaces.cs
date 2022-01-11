namespace ExInterfaces
{
        interface IControl
        {
            void Paint();
        }

        interface IListBox
        {
            void SetText(string text);
        }

        interface IComboBox: IControl, IListBox {}

        interface IDataBound
        {
            void Bind(BinaryReader b);
        }

        public class EditBox: IComboBox, IDataBound
        {
            public void Paint() {}
            public void SetText(string text) {}
            public void Bind(BinaryReader b) {}
        }

}

