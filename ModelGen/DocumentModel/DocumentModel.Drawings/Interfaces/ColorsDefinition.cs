namespace DocumentModel.Drawings;

/// <summary>
/// Color Transform Definitions.
/// </summary>
public interface ColorsDefinition
{
  public ColorTransformCategories? ColorTransformCategories { get ; set; }
  
  public ExtensionList3? ExtensionList { get ; set; }
  
}
