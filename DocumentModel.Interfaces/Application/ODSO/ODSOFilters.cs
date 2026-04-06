
namespace DocumentModel.Application;

/// <summary>
/// Represents all filters applied to the attached mail merge data source.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilters?view=office-pia"/>
public partial interface IODSOFilters: IModelCollection<IODSOFilter>
{
}

