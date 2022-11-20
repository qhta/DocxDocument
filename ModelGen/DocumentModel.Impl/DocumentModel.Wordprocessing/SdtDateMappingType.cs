namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XML Data Date Storage Format.
/// </summary>
public class SdtDateMappingType: ISdtDateMappingType
{
  /// <summary>
  /// Date Storage Type
  /// </summary>
  public DateFormatValues? Val
  {
    get;
    set;
  }
  
}
