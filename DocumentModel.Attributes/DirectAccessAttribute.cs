namespace DocumentModel;

/// <summary>
/// Specifies Ithat direct access is enabled or disabled for a class or property.
/// </summary>
/// <remarks>Apply this attribute to a class or property to control whether direct access is permitted. This can
/// be used to restrict or allow certain behaviors at runtime or during serialization, depending on the consuming
/// framework.</remarks>
/// <param name="isEnabled">true to enable direct access; otherwise, false. The default is true.</param>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public class DirectAccessAttribute(bool isEnabled = true) : Attribute
{
  /// <summary>
  /// Can be enabled or disabled.
  /// </summary>
  public bool IsEnabled => isEnabled;
}
