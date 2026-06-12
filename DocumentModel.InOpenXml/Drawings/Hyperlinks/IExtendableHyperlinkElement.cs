namespace DocumentModel.Drawings;
/// <summary>
///   Represents a hyperlink element that supports additional extension properties.
/// </summary>
public interface IExtendableHyperlinkElement
{
  /// <summary>
  ///   Collection of extension elements for additional hyperlink properties.
  /// </summary>
  public HyperlinkExtensionList? HyperlinkExtensionList { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}