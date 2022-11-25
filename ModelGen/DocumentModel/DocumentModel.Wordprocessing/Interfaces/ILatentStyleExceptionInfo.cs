namespace DocumentModel.Wordprocessing;

/// <summary>
/// Latent Style Exception.
/// </summary>
public interface ILatentStyleExceptionInfo // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Primary Style Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Latent Style Locking Setting
  /// </summary>
  public System.Boolean? Locked { get ; set; }
  
  /// <summary>
  /// Override default sorting order
  /// </summary>
  public System.Int32? UiPriority { get ; set; }
  
  /// <summary>
  /// Semi hidden text override
  /// </summary>
  public System.Boolean? SemiHidden { get ; set; }
  
  /// <summary>
  /// Unhide when used
  /// </summary>
  public System.Boolean? UnhideWhenUsed { get ; set; }
  
  /// <summary>
  /// Latent Style Primary Style Setting
  /// </summary>
  public System.Boolean? PrimaryStyle { get ; set; }
  
}
