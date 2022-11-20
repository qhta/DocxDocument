namespace DocumentModel.Drawing;

/// <summary>
/// default tail line end style is none.
/// </summary>
public class TailEnd: ITailEnd
{
  /// <summary>
  /// Line Head/End Type
  /// </summary>
  public LineEndValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Width of Head/End
  /// </summary>
  public LineEndWidthValues? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// Length of Head/End
  /// </summary>
  public LineEndLengthValues? Length
  {
    get;
    set;
  }
  
}
