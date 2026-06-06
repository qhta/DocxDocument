namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents a single instance of a custom property for a smart tag.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customproperty?view=word-pia"/>
public interface ICustomProperty : IInteropObject
{
  /// <summary>
  /// Gets the name of the custom property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customproperty.name?view=word-pia"/>
  public string Name { get; }	
  /// <summary>
  /// Gets or sets the value of the custom property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customproperty.value?view=word-pia"/>
  public string Value { get; set; }	

  #region methods	
/// <summary>
  /// Deletes the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customproperty.delete?view=word-pia"/>
  public void Delete();	
  #endregion methods
}
