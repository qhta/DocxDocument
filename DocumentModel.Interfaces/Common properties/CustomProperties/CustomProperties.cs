namespace DocumentModel.Properties;

/// <summary>
/// A collection of CustomProperty objects that represents the properties related to a smart tag.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customproperties?view=word-pia"/>
public partial interface ICustomProperties : IModelCollection<ICustomProperty>
{
}
