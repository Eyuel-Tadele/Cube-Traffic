using UnityEngine;
using GoogleMobileAds.Api;
using System;
using UnityEngine.UI;


public class AdmobAds : MonoBehaviour
{
    private BannerView adBanner;
    private InterstitialAd adinterstitial;
    private string idApp, idBanner, idInterestitial;

    [SerializeField]
    Button Btninterstitial;



    private void Start()
    {

        Btninterstitial.interactable = false;
        idApp = "ca-app-pub-1032952190970326~8320718896";
        idBanner = "ca-app-pub-1032952190970326/3998330506";
        idInterestitial = "ca-app-pub-1032952190970326/1180595473";

        MobileAds.Initialize (idApp);
        RequestBannerAd();
        RequestInterstitialAd();
    }

    #region Banner Methods
    public void RequestBannerAd()
    {
        adBanner = new BannerView(idBanner, AdSize.Banner, AdPosition.Top);
        AdRequest request = AdRequestBuild();
        adBanner.LoadAd(request);
    }

    public void DestroyBanerAd()
    {
        if (adBanner != null)
            adBanner.Destroy();
    }
    #endregion


    #region Interesitial methods -----------------
    public void RequestInterstitialAd()
    {
        adinterstitial = new InterstitialAd(idInterestitial);
        AdRequest request = AdRequestBuild();
        adinterstitial.LoadAd(request);

        //atach events
        adinterstitial.OnAdLoaded += this.HandleOnAdLoaded;
        adinterstitial.OnAdOpening += this.HandleOnAdOpening;
        adinterstitial.OnAdClosed += this.HandleOnAdClosed;
    }

    public void ShowInterstitialAd()
    {
        if (adinterstitial.IsLoaded())
            adinterstitial.Show();
    }

    public void DestroyInterstitialAd()
    {
        adinterstitial.Destroy();
    }

    //intenrstitial ad events
    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        //when Interestitial ad is loaded and rady to show
        Btninterstitial.interactable = true;//butoon is rady to click(enabled)

    }

    public void HandleOnAdOpening(object sender, EventArgs args)
    {
        //when Interestitial ad is alrady shown
        Btninterstitial.interactable = false;//disable the button

    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        //when Interestitial ad is closed closed
        adinterstitial.OnAdLoaded -= this.HandleOnAdLoaded;
        adinterstitial.OnAdOpening -= this.HandleOnAdOpening;
        adinterstitial.OnAdClosed -= this.HandleOnAdClosed;
        RequestInterstitialAd(); //requst new interstitial ad after closed

    }

    #endregion



    AdRequest AdRequestBuild()
    {
        return new AdRequest.Builder().Build();
    }

    void ONDestroy()
    {
        DestroyBanerAd();
        DestroyInterstitialAd();

        //deattach events

        adinterstitial.OnAdLoaded -= this.HandleOnAdLoaded;
        adinterstitial.OnAdOpening -= this.HandleOnAdOpening;
        adinterstitial.OnAdClosed -= this.HandleOnAdClosed;
    }



}
