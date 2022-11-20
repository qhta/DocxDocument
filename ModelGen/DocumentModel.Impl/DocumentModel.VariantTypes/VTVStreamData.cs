namespace DocumentModel.VariantTypes;

/// <summary>
/// Binary Versioned Stream.
/// </summary>
public class VTVStreamData: IVTVStreamData
{
  /// <summary>
  /// VSTREAM Version Attribute
  /// </summary>
  public string? Version
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text
  {
    get;
    set;
  }
  
}
