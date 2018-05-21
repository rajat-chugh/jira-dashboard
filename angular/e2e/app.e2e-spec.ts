import { JiraDashboardTemplatePage } from './app.po';

describe('JiraDashboard App', function() {
  let page: JiraDashboardTemplatePage;

  beforeEach(() => {
    page = new JiraDashboardTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
