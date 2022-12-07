namespace DocumentModel.Drawings;

/// <summary>
/// XY Adjust Handle.
/// </summary>
public class AdjustHandleXYImpl: ModelElement<DocumentFormat.OpenXml.Drawing.AdjustHandleXY>, AdjustHandleXY
{
  /// <summary>
  /// Position.
  /// </summary>
  public Boolean? Position
  {
    get;
    set;
  }
  
}
