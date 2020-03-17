using Abp.Application.Navigation;
using Abp.Localization;

namespace MetroDevABM.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See Views/Layout/_TopMenu.cshtml file to know how to render menu.
    /// </summary>
    public class MetroDevABMNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", MetroDevABMConsts.LocalizationSourceName),
                        url: "",
                        icon: "fa fa-home"
                        )
                )
                .AddItem(new MenuItemDefinition(
                    "Client",
                    new LocalizableString("Client", MetroDevABMConsts.LocalizationSourceName),
                    url: "Client",
                    icon: "fa fa-user"
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Catalog",
                        new LocalizableString("Catalog", MetroDevABMConsts.LocalizationSourceName),
                        icon: "fa fa-cubes"
                        )
                    .AddItem(
                        new MenuItemDefinition(
                            "Gender",
                            new LocalizableString("Gender", MetroDevABMConsts.LocalizationSourceName),
                            url: "Gender",
                            icon: "fa fa-cogs"
                            )
                     )
                    .AddItem(
                        new MenuItemDefinition(
                            "ClientType",
                            new LocalizableString("ClientType", MetroDevABMConsts.LocalizationSourceName),
                            url: "ClientType",
                            icon: "fa fa-user-md"
                            )
                     )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", MetroDevABMConsts.LocalizationSourceName),
                        url: "About",
                        icon: "fa fa-info"
                        )
                );
        }
    }
}
