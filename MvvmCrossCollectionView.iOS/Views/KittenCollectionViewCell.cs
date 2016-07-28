using Foundation;
using System;
using UIKit;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;
using MvvmCrossCollectionView.Core.Services;

namespace MvvmCrossCollectionView.iOS
{
    public partial class KittenCollectionViewCell : MvxCollectionViewCell
    {
		public static readonly NSString Key = new NSString("KittenCollectionViewCell");
		private readonly MvxImageViewLoader _loader;

        public KittenCollectionViewCell (IntPtr handle) : base (handle)
        {
			_loader = new MvxImageViewLoader(() => MainImage);

			this.DelayBind(() => {
				var set = this.CreateBindingSet<KittenCollectionViewCell, Kitten>();
				set.Bind(NameLabel).To(kitten => kitten.Name);
				set.Bind(PriceLabel).To(kitten => kitten.Price);
				set.Bind(_loader).To(kitten => kitten.ImageUrl);
				set.Apply();
			});
        }
	}
}