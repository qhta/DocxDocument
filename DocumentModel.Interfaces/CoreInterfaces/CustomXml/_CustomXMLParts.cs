using System.Collections;

namespace DocumentModel.CustomXml;

/// <summary>
/// Represents a collection of _CustomXMLPart objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts?view=office-pia"/>
public partial interface _CustomXMLParts: InteropCollection<CustomXMLPart>
{
}

