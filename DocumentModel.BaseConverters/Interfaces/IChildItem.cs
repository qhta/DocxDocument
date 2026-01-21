namespace DocumentModel;
/// <summary>
/// Interface fo model elements that are child items of a parent object.
/// </summary>
public interface IChildItem
{
  /// <summary>
  /// Collection that contains this item.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public object? Parent { get; set; }
}