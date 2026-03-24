using System.Collections;

namespace DocumentModel.Interfaces;

/// <summary>
/// Represents the `WebPageFonts` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webpagefonts?view=office-pia"/>
public partial interface WebPageFonts: InteropCollection<WebPageFont>
{
}

