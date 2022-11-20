namespace DocumentModel.VariantTypes;

/// <summary>
/// Basic String.
/// </summary>
public class VTBString: IVTBString
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text
  {
    get;
    set;
  }
  
}
