namespace DocumentModel.Interfaces;

/// <summary>
/// Basic interface for all interop objects, providing common properties such as Application, Creator, and Parent.
/// </summary>
public interface InteropObject
{
  ///// <summary>
  ///// Returns an Application object that represents the Microsoft Word application.
  ///// </summary>
  ///// <remarks>
  ///// If the object was created in Microsoft Word, this property returns the hexadecimal number 4D535744,
  ///// which represents the string "MSWD." This value can also be represented by the constant wdCreatorCode.
  ///// </remarks>
  //public object Application { get; }

  ///// <summary>
  ///// Returns a 32-bit integer that indicates the application in which the specified object was created.
  ///// </summary>
  //public int Creator { get; }

  /// <summary>
  /// Returns an object that represents the parent object of the specified object.
  /// </summary>
  public object Parent { get; }
}
