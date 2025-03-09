describe('main', () => {
  it('adding', () => {
    cy.visit('http://localhost:5173')
    cy.get(".app-container").within(()=> {
      cy.get(".form-container").within(()=>{
        cy.get("input").first().type("name")
        .next().type("090")
        .next().click()
      })
      cy.root()
      .get(".contacts-list").get(".contact-item").get("span")
      .should('contain', 'name - 090')
    })
  })
  it('editing', () => {
    cy.visit('http://localhost:5173')
    cy.get(".app-container").within(()=> {
      cy.get(".form-container").within(()=>{
        cy.get("input").first().type("name")
        .next().type("090")
        .next().click()
      })
      cy.root()
      .get(".contacts-list").get(".contact-item").get(".actions").first().click()
      cy.root().get(".form-container").within(()=>{
        cy.get("input").first().type("name")
        .next().type("090")
        .next().click()
      })
    })
  })
  it('deleting', () => {
    cy.visit('http://localhost:5173')
    cy.get(".app-container").within(()=> {
      cy.get(".form-container").within(()=>{
        cy.get("input").first().type("name")
        .next().type("090")
        .next().click()
      })
      cy.root()
      .get(".contacts-list").within(()=>{
        cy.get(".contact-item").get(".actions").children().last().click()
        cy.root().get('.contact-item').should('not.exist')
      })
    })
  })
  it('sorting', () => {
    cy.visit('http://localhost:5173')
    cy.get(".app-container").within(()=> {
      cy.get(".form-container").within(()=>{
        cy.get("input").first().type("name")
        .next().type("090")
        .next().click()
        cy.root().get("input").first().type("eman")
        .next().type("909")
        .next().click()
      })
      cy.root()
      .get(".buttons-container").children().first().click()
      cy.root()
      .get(".contacts-list").within(()=>{
        cy.get(".contact-item").first().should('contain', "eman")
      })
    })
  })
})