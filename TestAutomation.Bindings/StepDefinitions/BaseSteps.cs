using TestAutomation.Bindings.Contexts;
using TestAutomation.PageObjects.Factories;

namespace TestAutomation.Bindings.StepDefinitions
{
    public abstract class BaseSteps 
    {
        protected readonly IPageObjectFactory PageObjectFactory;
        protected readonly PageContext PageContext;

        protected BaseSteps(IPageObjectFactory pageObjectFactory, PageContext pageContext)
        {
            PageObjectFactory = pageObjectFactory;
            PageContext = pageContext;
        }
    }
}
