namespace DocxDocument.Model;

public class ListProperties
{
  public ListProperties(int listId, ListDefinition listDef, int listLevel, bool isStartingList, int isEndingLists)
  {
    this.ListId = listId;
    this.ListDef = listDef;
    this.ListLevel = listLevel;
    this.IsStartingList = isStartingList;
    this.IsEndingList = isEndingLists;
  }

  public int ListId { get; }

  public ListDefinition ListDef { get; }

  public int ListLevel { get; }

  public ListType ListType => ListDef.Levels[ListLevel].ListType;

  public NumberingFormat NumberFormat => ListDef.Levels[ListLevel].NumberingFormat;

  public bool IsStartingList { get; }

  public int IsEndingList { get; }
}