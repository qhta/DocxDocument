using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of COM add-ins registered in the Windows registry.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddins?view=office-pia
/// </remarks>
public partial interface COMAddIns: InteropCollection<COMAddIn>
{
}
