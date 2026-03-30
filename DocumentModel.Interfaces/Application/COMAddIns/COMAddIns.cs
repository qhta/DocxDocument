using System.Collections;
using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// A collection of COM add-ins registered in the Windows registry.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddins?view=office-pia"/>
public partial interface ICOMAddIns: IModelCollection<ICOMAddIn>
{
}

