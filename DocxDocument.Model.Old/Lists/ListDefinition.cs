namespace DocxDocument.Model;

public class ListDefinition: DocumentItem
{

  [XmlAttribute("MultiLevelType")]
  public MultilevelType MultiLevelType { get; set; }

  //public Int64 Nsid { get; }

  //public Int64 TemplateCode { get; }

  //public string AbstractNumDefinitionName { get; }

  //public string StyleLink { get; }

  //public string NumberingStyleLink { get; }

  public ItemsCollection<ListLevel> Levels { get; } = new ItemsCollection<ListLevel>();

  [XmlIgnore]
  public List<ListLevel> LevelsList
  { 
    get => Levels.ToList();
  }

  [XmlAttribute("UsageCount")]
  public int UsageCount 
  {
    get => LevelsList.Sum(item => item.UsageCount);
    set { } 
  }
}