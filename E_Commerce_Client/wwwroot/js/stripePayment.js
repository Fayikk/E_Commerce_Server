redirectToCheckout = function (sessionId) {
    var stripe = Stripe("pk_test_51MIUdEB01rwBMrJ2r3omjfx85RcWcyRMhSJpb7ARsljcGnmq56yDeEPxFqRBQHwfTF8slZnMRp1rSwjopJq5b16r00ubjbOu8A");
    stripe.redirectToCheckout({ sessionId: sessionId });
}