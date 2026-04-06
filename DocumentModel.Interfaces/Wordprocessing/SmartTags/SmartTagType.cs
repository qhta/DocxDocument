namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a type of smart tag.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagtype?view=word-pia"/>
public interface ISmartTagType : IModelObject
{
  /// <summary>
  /// Returns the name of the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagtype.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// Returns a SmartTagActions collection that represents the collection of actions available on a smart tag.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagtype.smarttagactions?view=word-pia"/>
  public ISmartTagActions SmartTagActions { get; }
  /// <summary>
  /// Returns a SmartTagRecognizers collection for an application.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagtype.smarttagrecognizers?view=word-pia"/>
  public ISmartTagRecognizers SmartTagRecognizers { get; }
  /// <summary>
  /// Returns a String that represents a friendly name for a smart tag type.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagtype.friendlyname?view=word-pia"/>
  public string FriendlyName { get; }

}
