namespace DocumentModel;
/// <summary>
/// Interface for providing properties of a component.
/// </summary>
public interface IPropertiesProvider
{
  /// <summary>
  /// All properties of the component that are available.
  /// It is a function as KnownProperties can be a static property.
  /// </summary>
  public KnownProperties GetKnownProperties();
}