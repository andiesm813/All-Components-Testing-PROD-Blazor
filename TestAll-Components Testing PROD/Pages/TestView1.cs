using Bunit;
using Microsoft.Extensions.DependencyInjection;
using All_Components_Testing_PROD.Pages;
using All_Components_Testing_PROD.Northwind;

namespace TestAll_Components_Testing_PROD
{
	public class TestView1
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCardModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule),
				typeof(IgbExpansionPanelModule),
				typeof(IgbGridModule),
				typeof(IgbTreeModule),
				typeof(IgbAvatarModule),
				typeof(IgbChipModule),
				typeof(IgbDropdownModule),
				typeof(IgbDropdownItemModule),
				typeof(IgbCheckboxModule),
				typeof(IgbSwitchModule),
				typeof(IgbRadioGroupModule),
				typeof(IgbRadioModule),
				typeof(IgbRatingModule),
				typeof(IgbSliderModule),
				typeof(IgbListModule),
				typeof(IgbDatePickerModule),
				typeof(IgbInputModule),
				typeof(IgbTabsModule),
				typeof(IgbCalendarModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<View1>();
			Assert.NotNull(componentUnderTest);
		}
	}
}