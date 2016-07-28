using System;
using CoreGraphics;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using MvvmCrossCollectionView.Core.ViewModels;
using ObjCRuntime;
using UIKit;

namespace MvvmCrossCollectionView.iOS.Views {
	[MvxFromStoryboard]
	public partial class FirstView : MvxCollectionViewController {

		public FirstView(IntPtr handle) : base(handle) {
			Title = "Kitten CollectionView";

			CollectionView.BackgroundColor = UIColor.White;

			CollectionView.WeakDelegate = new CollectionViewFlowDelegate();
		}

		public override void ViewDidLoad() {
			
			base.ViewDidLoad();

			var source = new MvxCollectionViewSource(CollectionView, KittenCollectionViewCell.Key);
			CollectionView.Source = source;

			var set = this.CreateBindingSet<FirstView, FirstViewModel>();
			set.Bind(source).To(vm => vm.Kittens);
			set.Apply();

			CollectionView.ReloadData();
		}
	}

}
