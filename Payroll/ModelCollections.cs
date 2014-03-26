using System.Collections.ObjectModel;

namespace ModelsLibrary.Payroll
{
    public class TaxGroupCollection : ObservableCollection<TaxGroup>
    { }

    public class PhilhealthContributionCollection : Collection<PhilhealthContribution>
    { }

    public class SssContributionCollection : ObservableCollection<SssContribution>
    { }
}
