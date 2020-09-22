namespace MultipleInheritance
{
    public class TextBox : UIControl, IDraggable, IDroppable
    {
        public void Drag()
        {
            throw new System.NotImplementedException();
        }

        public void Drop()
        {
            throw new System.NotImplementedException();
        }
    }
}