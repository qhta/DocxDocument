namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of CustomProperty objects that represents the properties related to a smart tag.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customproperties?view=word-pia"/>
public partial class CustomProperties : InteropCollection<CustomProperty>
{


  #region methods

/// <summary>
  /// Adds a custom property to the collection.
  /// </summary>
  /// <param name="name">The name of the custom property.</param>
  /// <param name="value">The value of the custom property.</param>
  /// <returns>The created <see cref="CustomProperty"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customproperties.add?view=word-pia"/>
  public CustomProperty Add(string name, string value) { throw new NotImplementedException(); }

  #endregion methods
}
