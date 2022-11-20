namespace DocumentModel.Spreadsheet;

/// <summary>
/// Discrete Grouping Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFieldItem))]
public class DiscreteProperties: IDiscreteProperties
{
  /// <summary>
  /// Mapping Index Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
