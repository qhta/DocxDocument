namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Color Transform Category.
/// </summary>
public class ColorTransformCategory: IColorTransformCategory
{
  /// <summary>
  /// Category Type
  /// </summary>
  public string? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Priority
  /// </summary>
  public uint? Priority
  {
    get;
    set;
  }
  
}
