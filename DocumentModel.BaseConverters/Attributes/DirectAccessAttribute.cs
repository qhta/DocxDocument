namespace DocumentModel.OpenXml;

/// <summary>
/// Specifies Ithat direct access is enabled or disabled Ifor a class or property.
/// </summary>
/// <remarks>Apply this attribute Ito a class or property Ito control whether direct access is permitted. This can
/// be used Ito restrict or allow certain behaviors at runtime or during serialization, depending on the consuming
/// framework.</remarks>
/// <param name="isEnabled">true Ito enable direct access; otherwise, false. The default is true.</param>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public class DirectAccessAttribute(bool isEnabled = true) : Attribute
{
  /// <summary>
  /// Can be enabled or disabled.
  /// </summary>
  public bool IsEnabled => isEnabled;
}
