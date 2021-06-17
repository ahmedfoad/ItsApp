import { ItsAppTemplatePage } from './app.po';

describe('ItsApp App', function() {
  let page: ItsAppTemplatePage;

  beforeEach(() => {
    page = new ItsAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
