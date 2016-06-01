using System;
using System.Linq;
using System.Reactive.Linq;
using ReactiveUI;
using System.Diagnostics;
using System.Threading;

namespace ReactiveUIPlaygroundBusiness
{
	public class MainViewModel: ReactiveObject
	{
		string _TextInput;
		public string TextInput
		{
			get { return _TextInput; }
			set {this.RaiseAndSetIfChanged(ref _TextInput, value); }
		}

		public ReactiveCommand StartStopCounting { get; private set;}

		ObservableAsPropertyHelper<string> _TextOutput;
		public string TextOutput => _TextOutput.Value;

		bool _countDirection;
		public bool CountDirection
		{
			get { return _countDirection; }
			set { this._countDirection = value; }
		}

		ObservableAsPropertyHelper<string> _CounterText;
		public string CounterText => _CounterText.Value;

		/*
		string _TextOutput;
		public string TextOutput
		{
			get { return _TextOutput;}
			set { this._TextOutput = value;}
		}
		*/

		public MainViewModel()
		{
			_TextOutput = this.WhenAnyValue(x =>  x.TextInput).Select(y => y.ToUpper()).ToProperty(this, x=> x.TextOutput, "");

			_CounterText = this.WhenAnyValue(x => x.CounterText).Select(text => (Convert.ToInt32(text) + 1).ToString()).ToProperty(
				this, x => x.CounterText, "0");
			                   //var startStopCountingObservable = this.WhenAnyValue(x => x.CountDirection, () ;
		}


	}
}

