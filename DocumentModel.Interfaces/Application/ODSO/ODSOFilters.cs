
namespace DocumentModel.Application;

/// <summary>
/// Represents all filters applied to the attached mail merge data source.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters?view=office-pia"/>
public partial interface ODSOFilters: IModelCollection<ODSOFilter>
{
}

