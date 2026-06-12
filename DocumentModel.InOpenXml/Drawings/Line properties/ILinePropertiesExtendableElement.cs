namespace DocumentModel.Drawings;
/// <summary>
///   Represents an element that supports extensibility for line properties through an extension list.
/// </summary>
public interface ILinePropertiesExtendableElement: ICollectionItem
{
  /// <summary>
  ///   List of extension properties for the line, used for extensibility scenarios.
  /// </summary>
  /// <remarks>
  ///   Use this property to store or retrieve additional line properties associated with the line that are not defined in the standard schema.
  /// </remarks>
  public LinePropertiesExtensionList? LinePropertiesExtensionList { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}