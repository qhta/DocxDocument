namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single mapped data field.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mappeddatafield?view=word-pia"/>
public interface IMappedDataField : IModelObject
{
  /// <summary>
  /// Returns the index number of the mapped data field in the collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mappeddatafield.index?view=word-pia"/>
  public int Index { get; }
  /// <summary>
  /// Returns the name of the data source field mapped to this address element.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mappeddatafield.datafieldname?view=word-pia"/>
  public string DataFieldName { get; }
  /// <summary>
  /// Returns the name of the mapped address element.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mappeddatafield.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// Returns the value of the mapped data field for the active record.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mappeddatafield.value?view=word-pia"/>
  public string Value { get; }
  /// <summary>
  /// Returns or sets the index of the mapped data source field.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mappeddatafield.datafieldindex?view=word-pia"/>
  public int DataFieldIndex { get; set; }

}
