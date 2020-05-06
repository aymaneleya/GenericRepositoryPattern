using System;


namespace ConsoleApp1
{ 
[Table("Author")]
public partial class Author : IEntity
{
    public int Id { get; set; }

    public string authorName { get; set; }

    private class TableAttribute : Attribute
    {
        private string v;

        public TableAttribute(string v)
        {
            this.v = v;
        }
    }
}
}
