namespace Soduku
{
    public class PostionValue
    {
        public string Postion;
        public Operatoration operatoration;
        public int Value;

        public PostionValue(string postion, int value, Operatoration operatoration = Operatoration.Equal)
        {
            this.Postion = postion;
            this.Value = value;
            this.operatoration = operatoration;
        }

        public RelationShip GetRelationShip(PostionValue otherPostionValue)
        {
            return RelationShip.NotConfirm;
        }
    }
}