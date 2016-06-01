using Android.App;
using Android.Widget;
using Android.OS;
using ReactiveUIPlaygroundBusiness;
using ReactiveUI;
using System;

namespace ReactiveUIPlayground
{
	[Activity(Label = "ReactiveUIPlayground", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity,IViewFor<MainViewModel>
	{
		int count = 1;

		public MainViewModel viewModel;

		public EditText editTextInput;
		public TextView textViewOutput;
		public Button buttonStartStop;
		public Button buttonReset;
		public TextView textViewCounter;

		public MainViewModel ViewModel
		{
			get
			{
				throw new NotImplementedException();
			}

			set
			{
				throw new NotImplementedException();
			}
		}

		object IViewFor.ViewModel
		{
			get
			{
				return viewModel;
			}

			set
			{
				throw new NotImplementedException();
			}
		}

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

			viewModel = new MainViewModel();

			editTextInput = ((EditText)FindViewById(Resource.Id.editTextInput));
			textViewOutput = (TextView)FindViewById(Resource.Id.textViewOutput);
			this.Bind(viewModel, a => a.TextInput, asd => asd.editTextInput.Text);
			this.Bind(viewModel, gsg => gsg.TextOutput, dsde => dsde.textViewOutput.Text);
			buttonStartStop.comman
		}
	}
}


