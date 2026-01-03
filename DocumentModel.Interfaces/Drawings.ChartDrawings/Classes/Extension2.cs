namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the Extension2 Class.
/// </summary>
public interface Extension2: IModelElement
{
  /// <summary>
  ///   uri, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Uri { get; set; }
}