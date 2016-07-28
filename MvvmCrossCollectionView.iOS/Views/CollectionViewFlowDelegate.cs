using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace MvvmCrossCollectionView.iOS {
	public class CollectionViewFlowDelegate : UICollectionViewDelegateFlowLayout {

		public override CGSize GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath) {
			return new CGSize(240, 400);
		}

		public override UIEdgeInsets GetInsetForSection(UICollectionView collectionView, UICollectionViewLayout layout, nint section) {
			return new UIEdgeInsets(0f, 0f, 0f, 0f);
		}

		public override nfloat GetMinimumInteritemSpacingForSection(UICollectionView collectionView, UICollectionViewLayout layout, nint section) {
			return 10;
		}

		public override nfloat GetMinimumLineSpacingForSection(UICollectionView collectionView, UICollectionViewLayout layout, nint section) {
			return 10;
		}
	}
}

