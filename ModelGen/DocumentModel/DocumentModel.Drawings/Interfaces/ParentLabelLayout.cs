namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ParentLabelLayout Class.
/// </summary>
public interface ParentLabelLayout
{
  /// <summary>
  /// val, this property is only available in Office 2016 and later.
  /// </summary>
  public ParentLabelLayoutVal? ParentLabelLayoutVal { get ; set; }
  
}
