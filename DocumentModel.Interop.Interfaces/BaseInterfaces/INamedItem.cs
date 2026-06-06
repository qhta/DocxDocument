namespace DocumentModel.Interop;	
/// <summary>
/// Interface for items that have a name.
/// </summary>
public interface INamedItem
{
  /// <summary>
  /// Gets the name of the item.
  /// </summary>
  public string Name { get; }  
}